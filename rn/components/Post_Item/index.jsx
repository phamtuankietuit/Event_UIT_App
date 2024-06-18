import { Image, Text, TouchableOpacity, View } from "react-native"
import logo from "../../assets/images/Logo.png"
import { FontAwesomeIcon } from '@fortawesome/react-native-fontawesome';
import {
    faEllipsis,
    faThumbsUp,
    faComment
} from '@fortawesome/free-solid-svg-icons';
const Post_Item = (
    {
        item,
        setLike
    }
) => {
    return (
        <View className="bg-white flex w-[97%] my-2 rounded-lg mx-2 p-3">
            <View className="flex flex-row h-[70px] justify-center ">
                <View className="w-[20%] flex items-center">
                    <Image
                        source={logo}
                        className="bg-white rounded-full w-[75%] h-[75%] me-4 "
                        resizeMode="contain"
                    />
                </View>
                <View className="w-[70%]">
                    <Text className="text-[18px] font-semibold mb-2">CLB Sách và hành động</Text>
                    <Text>10h trước</Text>
                </View>
                <View className="w-[10%] flex items-center">
                    <TouchableOpacity>
                        <FontAwesomeIcon icon={faEllipsis} color="#64748b" />
                    </TouchableOpacity>

                </View>
            </View>
            <View>
                <Text className="p-3">
                    Cùng theo dõi các trận của MSI hôm nay nhé

                    11h00: G2 vs PSG
                    16h00: BLG vs T1
                </Text>
                <View className="flex justify-center items-center mb-4">
                    <Image
                        source={logo}
                        className="w-[90%] bg-slate-100"
                        resizeMode="contain"
                    />
                </View>

            </View>
            <View className="flex flex-row justify-between">
                <TouchableOpacity>
                    <Text> 120 lượt thích</Text>
                </TouchableOpacity>
                <TouchableOpacity>
                    <Text> 200 bình luận</Text>
                </TouchableOpacity>

            </View>
            <View className="bg-slate-300 h-[1px] w-[100%] my-2" />
            <View className="flex flex-row justify-start">
                {
                    item.like === true ? (
                        <TouchableOpacity className="flex flex-row p-2 w-[50%] justify-center items-center " onPress={() => setLike(item.id, false)}>
                            <FontAwesomeIcon icon={faThumbsUp} color="#64748b" />
                            <Text className=" text-slate-500">  Đã thích</Text>
                        </TouchableOpacity>
                    ) : (
                        <TouchableOpacity className="flex flex-row p-2 w-[50%] justify-center items-center" onPress={() => setLike(item.id, true)}>
                            <FontAwesomeIcon icon={faThumbsUp} color="#06b6d4" />
                            <Text className=" text-cyan-500">  Thích</Text>
                        </TouchableOpacity>
                    )
                }
                <TouchableOpacity className="flex flex-row p-2 w-[50%] justify-center items-center ">
                    <FontAwesomeIcon icon={faComment} color="#64748b" />
                    <Text className=" text-slate-500">  Bình luận</Text>
                </TouchableOpacity>
            </View>
        </View>
    )
}

export default Post_Item